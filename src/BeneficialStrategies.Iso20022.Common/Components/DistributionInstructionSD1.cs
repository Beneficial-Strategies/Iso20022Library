// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action distribution instruction details.
/// </summary>
[IsoId("_N_uCcFB8Ee2KGNXAcFL5RA")]
[DisplayName("Distribution Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DistributionInstructionSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Tax category number assigned on the announcement to provide a breakdown at a category level on the inbound instruction to determine tax treatment as required by issuers, their agents, or tax authorities.
    /// </summary>
    [IsoId("_WZM14VB8Ee2KGNXAcFL5RA")]
    [DisplayName("Tax Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCtgy")]
    #endif
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory2> TaxCategory { get; init; } = new ValueList<TaxCategory2>(){};
    
    
    #nullable disable
    
}
