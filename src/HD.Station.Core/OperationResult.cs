﻿using System.Collections.Generic;
using System.Linq;

namespace HD.Station
{
    /// <summary>
    /// Represents the result of a operation.
    /// </summary>
    public class OperationResult
    {
        private static readonly OperationResult _success = new OperationResult { Succeeded = true };
        protected List<Fault> _errors = new List<Fault>();

        /// <summary>
        /// Flag indicating whether if the operation succeeded or not.
        /// </summary>
        /// <value>True if the operation succeeded, otherwise false.</value>
        public bool Succeeded { get; protected set; }

        /// <summary>
        /// An <see cref="IEnumerable{T}"/> of <see cref="Error"/>s containing an errors
        /// that occurred during the operation.
        /// </summary>
        /// <value>An <see cref="IEnumerable{T}"/> of <see cref="Error"/>s.</value>
        public IEnumerable<Fault> Errors => _errors;

        /// <summary>
        /// Returns an <see cref="OperationResult"/> indicating a successful operation.
        /// </summary>
        /// <returns>An <see cref="OperationResult"/> indicating a successful operation.</returns>
        public static OperationResult Success => _success;

        /// <summary>
        /// Creates an <see cref="OperationResult"/> indicating a failed operation, with a list of <paramref name="errors"/> if applicable.
        /// </summary>
        /// <param name="errors">An optional array of <see cref="Error"/>s which caused the operation to fail.</param>
        /// <returns>An <see cref="OperationResult"/> indicating a failed operation, with a list of <paramref name="errors"/> if applicable.</returns>
        public static OperationResult Failed(params Fault[] errors)
        {
            var result = new OperationResult { Succeeded = false };
            if (errors != null)
            {
                result._errors.AddRange(errors);
            }
            return result;
        }

        /// <summary>
        /// Converts the value of the current <see cref="OperationResult"/> object to its equivalent string representation.
        /// </summary>
        /// <returns>A string representation of the current <see cref="OperationResult"/> object.</returns>
        /// <remarks>
        /// If the operation was successful the ToString() will return "Succeeded" otherwise it returned
        /// "Failed : " followed by a comma delimited list of error codes from its <see cref="Errors"/> collection, if any.
        /// </remarks>
        public override string ToString()
        {
            return Succeeded ?
                   "Succeeded" :
                   string.Format("{0} : {1}", "Failed", string.Join(",", Errors.Select(x => x.Code).ToList()));
        }
    }
}