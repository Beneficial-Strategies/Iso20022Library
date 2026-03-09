// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the investment account and the financial instrument.
    /// </summary>
    [KnownType(typeof(InvestmentAccountOrFinancialInstrument1Choice.InvestmentAccount))]
    [KnownType(typeof(InvestmentAccountOrFinancialInstrument1Choice.FinancialInstrument))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestmentAccountOrFinancialInstrument1Choice.InvestmentAccount),nameof(InvestmentAccountOrFinancialInstrument1Choice.InvestmentAccount))]
    [JsonDerivedType(typeof(InvestmentAccountOrFinancialInstrument1Choice.FinancialInstrument),nameof(InvestmentAccountOrFinancialInstrument1Choice.FinancialInstrument))]
    #endif
    [IsoId("_UuOns9p-Ed-ak6NoX_4Aeg_-1126591105")]
    [DisplayName("Investment Account Or Financial Instrument 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestmentAccountOrFinancialInstrument1Choice_
    #else
    public abstract partial class InvestmentAccountOrFinancialInstrument1Choice_
    #endif
    {
    }
}
