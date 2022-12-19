namespace BlackJack.Core.Enums;

public enum GameStatus : byte
{
    Waiting = 0,
    PlayerInput = 1,
    DealerInput = 2,
    WinnerAnnouncement = 3,
    Ended = 4
}