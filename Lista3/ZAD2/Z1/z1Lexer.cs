//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from z1.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class z1Lexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		COMMENT=1, NUM=2, ADD=3, SUB=4, MUL=5, DIV=6, POW=7, LPAREN=8, RPAREN=9, 
		WS=10;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"COMMENT", "NUM", "ADD", "SUB", "MUL", "DIV", "POW", "LPAREN", "RPAREN", 
		"WS"
	};


	public z1Lexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public z1Lexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'+'", "'-'", "'*'", "'/'", "'^'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COMMENT", "NUM", "ADD", "SUB", "MUL", "DIV", "POW", "LPAREN", "RPAREN", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "z1.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static z1Lexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,10,58,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,
		2,7,7,7,2,8,7,8,2,9,7,9,1,0,1,0,5,0,24,8,0,10,0,12,0,27,9,0,1,0,1,0,1,
		0,1,0,1,1,4,1,34,8,1,11,1,12,1,35,1,2,1,2,1,3,1,3,1,4,1,4,1,5,1,5,1,6,
		1,6,1,7,1,7,1,8,1,8,1,9,4,9,53,8,9,11,9,12,9,54,1,9,1,9,1,25,0,10,1,1,
		3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,1,0,2,1,0,48,57,3,0,9,10,13,
		13,32,32,60,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,
		0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,1,21,
		1,0,0,0,3,33,1,0,0,0,5,37,1,0,0,0,7,39,1,0,0,0,9,41,1,0,0,0,11,43,1,0,
		0,0,13,45,1,0,0,0,15,47,1,0,0,0,17,49,1,0,0,0,19,52,1,0,0,0,21,25,5,35,
		0,0,22,24,9,0,0,0,23,22,1,0,0,0,24,27,1,0,0,0,25,26,1,0,0,0,25,23,1,0,
		0,0,26,28,1,0,0,0,27,25,1,0,0,0,28,29,5,10,0,0,29,30,1,0,0,0,30,31,6,0,
		0,0,31,2,1,0,0,0,32,34,7,0,0,0,33,32,1,0,0,0,34,35,1,0,0,0,35,33,1,0,0,
		0,35,36,1,0,0,0,36,4,1,0,0,0,37,38,5,43,0,0,38,6,1,0,0,0,39,40,5,45,0,
		0,40,8,1,0,0,0,41,42,5,42,0,0,42,10,1,0,0,0,43,44,5,47,0,0,44,12,1,0,0,
		0,45,46,5,94,0,0,46,14,1,0,0,0,47,48,5,40,0,0,48,16,1,0,0,0,49,50,5,41,
		0,0,50,18,1,0,0,0,51,53,7,1,0,0,52,51,1,0,0,0,53,54,1,0,0,0,54,52,1,0,
		0,0,54,55,1,0,0,0,55,56,1,0,0,0,56,57,6,9,0,0,57,20,1,0,0,0,4,0,25,35,
		54,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
