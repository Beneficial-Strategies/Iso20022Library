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
/// Parties related to an investment fund.
/// </summary>
[IsoId("_FCdpMF_6EeiNMJ262H2pWg")]
[DisplayName("Fund Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundParties1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Guarantor of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00080.
    /// </summary>
    [IsoId("_KGpUwV_6EeiNMJ262H2pWg")]
    [DisplayName("Guarantor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Guarntr")]
    #endif
    [IsoXmlTag("Guarntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactAttributes5? Guarantor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes5? Guarantor { get; init; } 
    #else
    public ContactAttributes5? Guarantor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that regularly monitors compliance with the legal regulations.
    /// </summary>
    [IsoId("_Nn5N8l_6EeiNMJ262H2pWg")]
    [DisplayName("Auditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Audtr")]
    #endif
    [IsoXmlTag("Audtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactAttributes5? Auditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes5? Auditor { get; init; } 
    #else
    public ContactAttributes5? Auditor { get; set; } 
    #endif
    
    /// <summary>
    /// Legal owner of the financial instrument. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_Nn5N81_6EeiNMJ262H2pWg")]
    [DisplayName("Trustee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trstee")]
    #endif
    [IsoXmlTag("Trstee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactAttributes5? Trustee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes5? Trustee { get; init; } 
    #else
    public ContactAttributes5? Trustee { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_F-x3wWALEeiNMJ262H2pWg")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedParty13? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedParty13? OtherParty { get; init; } 
    #else
    public ExtendedParty13? OtherParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
