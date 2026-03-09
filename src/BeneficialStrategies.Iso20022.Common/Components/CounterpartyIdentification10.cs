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
/// Set of information identifying the reporting counterparty.
/// </summary>
[IsoId("_CSkJq8gtEeuGrNSsxk3B0A")]
[DisplayName("Counterparty Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyIdentification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty in the transaction.
    /// </summary>
    [IsoId("_CT9308gtEeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? Identification { get; init; } 
    #else
    public OrganisationIdentification15Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
    /// </summary>
    [IsoId("_CT931cgtEeuGrNSsxk3B0A")]
    [DisplayName("Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sd")]
    #endif
    [IsoXmlTag("Sd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralRole1Code? Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralRole1Code? Side { get; init; } 
    #else
    public CollateralRole1Code? Side { get; set; } 
    #endif
    
    
    #nullable disable
    
}
