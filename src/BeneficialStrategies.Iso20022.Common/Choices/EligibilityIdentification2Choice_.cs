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
    /// Specifies the eligibility details.
    /// </summary>
    [KnownType(typeof(EligibilityIdentification2Choice.Country))]
    [KnownType(typeof(EligibilityIdentification2Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(EligibilityIdentification2Choice.IssuerCSDIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EligibilityIdentification2Choice.Country),nameof(EligibilityIdentification2Choice.Country))]
    [JsonDerivedType(typeof(EligibilityIdentification2Choice.FinancialInstrumentIdentification),nameof(EligibilityIdentification2Choice.FinancialInstrumentIdentification))]
    [JsonDerivedType(typeof(EligibilityIdentification2Choice.IssuerCSDIdentification),nameof(EligibilityIdentification2Choice.IssuerCSDIdentification))]
    #endif
    [IsoId("_oDDY8eLXEeWFtOV72FbX9w")]
    [DisplayName("Eligibility Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EligibilityIdentification2Choice_
    #else
    public abstract partial class EligibilityIdentification2Choice_
    #endif
    {
    }
}
