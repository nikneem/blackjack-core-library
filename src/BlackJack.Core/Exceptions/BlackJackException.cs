using BlackJack.Core.ErrorCodes;

namespace BlackJack.Core.Exceptions;

public class BlackJackException : Exception
{
    public BlackJackErrorCode ErrorCode { get; }
    public List<ErrorSubstituteDto> Substitutes { get; }

    protected BlackJackException(BlackJackErrorCode errorCode, string message, Exception? ex) : base(message, ex)
    {
        ErrorCode = errorCode;
    }

}