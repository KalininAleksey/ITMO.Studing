namespace ITMO.Studing.CScourse.Lab9.ColorTokeniser
{
    public interface ITokenVisitor
    {
        void Visit(ILineStartToken t);
        void Visit(ILineEndToken t);

        void Visit(ICommentToken t);
        void Visit(IDirectiveToken t);
        void Visit(IIdentifierToken t);
        void Visit(IKeywordToken t);
        void Visit(IWhiteSpaceToken t);

        void Visit(IOtherToken t);
    }
}