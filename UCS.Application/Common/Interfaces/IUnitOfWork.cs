namespace UCS.Application.Common.Interfaces;

public interface IUnitOfWork
{
    IStudent Student { get; }
    IDepartment Department { get; }
    IProfessor Professor { get; }
    ICourse Course { get; }
}