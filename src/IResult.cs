
namespace Boring
{
    public interface IResult
    {
        bool IsFailure { get; }
        bool IsSuccess { get; }
    }
}
