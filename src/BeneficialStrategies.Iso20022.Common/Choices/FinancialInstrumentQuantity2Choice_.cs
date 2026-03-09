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
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity2Choice.Unit),nameof(FinancialInstrumentQuantity2Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity2Choice.FaceAmount),nameof(FinancialInstrumentQuantity2Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity2Choice.AmortisedValue),nameof(FinancialInstrumentQuantity2Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity2Choice.Code),nameof(FinancialInstrumentQuantity2Choice.Code))]
    #endif
    [IsoId("_Sn-F09p-Ed-ak6NoX_4Aeg_-85763525")]
    [DisplayName("Financial Instrument Quantity 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity2Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity2Choice_
    #endif
    {
    }
}
