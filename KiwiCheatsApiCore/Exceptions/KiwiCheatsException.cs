using System;

namespace KiwiCheatsApiCore.Exceptions {
    public class KiwiCheatsException : Exception {
        protected KiwiCheatsException(string message) : base(message) { }
    }
}