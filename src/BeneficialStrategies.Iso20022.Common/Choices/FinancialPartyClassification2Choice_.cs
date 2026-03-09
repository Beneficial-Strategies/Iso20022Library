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
    /// Specifies the classification of a financial institution.
    /// </summary>
    [KnownType(typeof(FinancialPartyClassification2Choice.Code))]
    [KnownType(typeof(FinancialPartyClassification2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialPartyClassification2Choice.Code),nameof(FinancialPartyClassification2Choice.Code))]
    [JsonDerivedType(typeof(FinancialPartyClassification2Choice.Proprietary),nameof(FinancialPartyClassification2Choice.Proprietary))]
    #endif
    [IsoId("_IH7-oSI4Ee2zWP9pqvmqdw")]
    [DisplayName("Financial Party Classification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialPartyClassification2Choice_
    #else
    public abstract partial class FinancialPartyClassification2Choice_
    #endif
    {
    }
}
