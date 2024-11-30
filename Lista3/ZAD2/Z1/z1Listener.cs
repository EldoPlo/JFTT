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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="z1Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public interface Iz1Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="z1Parser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] z1Parser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="z1Parser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] z1Parser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd([NotNull] z1Parser.AddContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd([NotNull] z1Parser.AddContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Divide</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivide([NotNull] z1Parser.DivideContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Divide</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivide([NotNull] z1Parser.DivideContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] z1Parser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] z1Parser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Multiply</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiply([NotNull] z1Parser.MultiplyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Multiply</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiply([NotNull] z1Parser.MultiplyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Subtract</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtract([NotNull] z1Parser.SubtractContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Subtract</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtract([NotNull] z1Parser.SubtractContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Negate</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegate([NotNull] z1Parser.NegateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Negate</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegate([NotNull] z1Parser.NegateContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Parentheses</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParentheses([NotNull] z1Parser.ParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Parentheses</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParentheses([NotNull] z1Parser.ParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Power</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPower([NotNull] z1Parser.PowerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Power</c>
	/// labeled alternative in <see cref="z1Parser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPower([NotNull] z1Parser.PowerContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NegPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegPow([NotNull] z1Parser.NegPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NegPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegPow([NotNull] z1Parser.NegPowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesesPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesesPow([NotNull] z1Parser.ParenthesesPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesesPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesesPow([NotNull] z1Parser.ParenthesesPowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SubPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubPow([NotNull] z1Parser.SubPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SubPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubPow([NotNull] z1Parser.SubPowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MulPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulPow([NotNull] z1Parser.MulPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MulPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulPow([NotNull] z1Parser.MulPowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AddPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddPow([NotNull] z1Parser.AddPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddPow([NotNull] z1Parser.AddPowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NumPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumPow([NotNull] z1Parser.NumPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumPow([NotNull] z1Parser.NumPowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DivPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivPow([NotNull] z1Parser.DivPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DivPow</c>
	/// labeled alternative in <see cref="z1Parser.powexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivPow([NotNull] z1Parser.DivPowContext context);
}