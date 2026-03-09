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
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument61Choice.Security))]
    [KnownType(typeof(FinancialInstrument61Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument61Choice.OtherAsset))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrument61Choice.Security),nameof(FinancialInstrument61Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument61Choice.CashAsset),nameof(FinancialInstrument61Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument61Choice.OtherAsset),nameof(FinancialInstrument61Choice.OtherAsset))]
    #endif
    [IsoId("_mDJucZNBEemQB_8XA98K0Q")]
    [DisplayName("Financial Instrument 61 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrument61Choice_
    #else
    public abstract partial class FinancialInstrument61Choice_
    #endif
    {
    }
}
