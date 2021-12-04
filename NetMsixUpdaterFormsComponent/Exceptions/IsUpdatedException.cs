using System;

namespace NetMsixUpdaterFormsComponent.Exceptions
{
    internal class IsUpdatedException : Exception
    {
        const string EXCEPTION_MESSAGE = "The assembly is already updated, verify this before call Start method";

        public IsUpdatedException() : base(message: EXCEPTION_MESSAGE)
            { /*Nothing*/ }
    }
}
