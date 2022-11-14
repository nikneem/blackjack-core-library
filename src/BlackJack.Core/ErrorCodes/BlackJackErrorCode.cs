namespace BlackJack.Core.ErrorCodes;

public abstract class BlackJackErrorCode
{
    public abstract string Code { get; }
    public virtual string TranslationKey => $"{ErrorNamespace}.{Code}";
    public virtual string ErrorNamespace => GetType().Name;
}