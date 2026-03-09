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
/// Costs and charges associated with the distribution or selling of a financial instrument. These may be one-off or recurring charges. These may be intended (ex ante) or actual (ex post).
/// </summary>
[IsoId("_nfxmIDciEeidBoT_PugKiA")]
[DisplayName("Costs And Charges")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CostsAndCharges1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference date applicable to all ex ante cost and charge disclosures. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 07160.
    /// </summary>
    [IsoId("_yV8bMIEgEeiw-daIkkmMqQ")]
    [DisplayName("Ex Ante Reference Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExAnteRefDt")]
    #endif
    [IsoXmlTag("ExAnteRefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExAnteReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExAnteReferenceDate { get; init; } 
    #else
    public System.DateOnly? ExAnteReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Reference date applicable to all ex post cost and charge disclosures. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 08120.
    /// </summary>
    [IsoId("_BDgaMZ7NEein281BT9rIxg")]
    [DisplayName("Ex Post Reference Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExPstRefDt")]
    #endif
    [IsoXmlTag("ExPstRefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExPostReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExPostReferenceDate { get; init; } 
    #else
    public System.DateOnly? ExPostReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Individual cost or charge associated with the distribution of selling of the financial instrument. This may be one-off or recurring. This may be ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_6VRRcIwREeicrr-UkGlMQA")]
    [DisplayName("Individual Cost Or Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvCostOrChrg")]
    #endif
    [IsoXmlTag("IndvCostOrChrg")]
    public ValueList<IndividualCostOrCharge1> IndividualCostOrCharge { get; init; } = new ValueList<IndividualCostOrCharge1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6VRRcIwREeicrr-UkGlMQA
    
    /// <summary>
    /// Additional information about costs and charges.
    /// </summary>
    [IsoId("_ZSKpMDcoEeidBoT_PugKiA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
