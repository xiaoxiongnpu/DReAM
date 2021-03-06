﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DReAMCompiler.Tokens
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dedent")]

    public enum TokenKind
    {
        EndOfFile = -1,
        Error = 0,
        NewLine = 1,
        Indent = 2,
        Dedent = 3,
        Comment = 4,
        Name = 8,
        Constant = 9,
        Dot = 31,
        Add = 32,
        AddEqual = 33,
        Subtract = 34,
        SubtractEqual = 35,
        Power = 36,
        PowerEqual = 37,
        Multiply = 38,
        MultiplyEqual = 39,
        FloorDivide = 40,
        FloorDivideEqual = 41,
        TrueDivide = 42,
        TrueDivideEqual = 43,
        Mod = 44,
        ModEqual = 45,
        LeftShift = 46,
        LeftShiftEqual = 47,
        RightShift = 48,
        RightShiftEqual = 49,
        BitwiseAnd = 50,
        BitwiseAndEqual = 51,
        BitwiseOr = 52,
        BitwiseOrEqual = 53,
        ExclusiveOr = 54,
        ExclusiveOrEqual = 55,
        LessThan = 56,
        GreaterThan = 57,
        LessThanOrEqual = 58,
        GreaterThanOrEqual = 59,
        Equals = 60,
        NotEquals = 61,
        LeftParenthesis = 62,
        RightParenthesis = 63,
        LeftBracket = 64,
        RightBracket = 65,
        LeftBrace = 66,
        RightBrace = 67,
        Comma = 68,
        Colon = 69,
        Semicolon = 70,
        Assign = 71,
        Twiddle = 72,
        At = 73,
        RightArrow = 74,
        ReturnAnnotation = 75,
        FirstKeyword = KeywordAnd,
        LastKeyword = KeywordNonlocal,
        KeywordAnd = 76,
        KeywordAssert = 77,
        KeywordBreak = 78,
        KeywordClass = 79,
        KeywordContinue = 80,
        KeywordDef = 81,
        KeywordDel = 82,
        KeywordElseIf = 83,
        KeywordElse = 84,
        KeywordExcept = 85,
        KeywordFinally = 86,
        KeywordFor = 87,
        KeywordFrom = 88,
        KeywordGlobal = 89,
        KeywordIf = 90,
        KeywordImport = 91,
        KeywordIn = 92,
        KeywordIs = 93,
        KeywordLambda = 94,
        KeywordNot = 95,
        KeywordOr = 96,
        KeywordPass = 97,
        KeywordRaise = 98,
        KeywordReturn = 99,
        KeywordTry = 100,
        KeywordWhile = 101,
        KeywordYield = 102,
        KeywordAs = 103,
        KeywordWith = 104,
        KeywordAsync = 105,
        KeywordNonlocal = 106,
        NLToken,
    }
}
