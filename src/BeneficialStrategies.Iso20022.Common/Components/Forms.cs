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
/// Processing characteristics linked to the instrument, ie, not to the market.
/// </summary>
[IsoId("_UBYIxdp-Ed-ak6NoX_4Aeg_-1907682961")]
[DisplayName("Forms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Forms
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Forms instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Forms( System.String reqApplicationForm,SignatureType1Code reqSignatureType )
    {
        ApplicationForm = reqApplicationForm;
        SignatureType = reqSignatureType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Physical application form is required.
    /// </summary>
    [IsoId("_UBYIxtp-Ed-ak6NoX_4Aeg_-1148549428")]
    [DisplayName("Application Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplForm")]
    #endif
    [IsoXmlTag("ApplForm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ApplicationForm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ApplicationForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ApplicationForm { get; init; } 
    #else
    public System.String ApplicationForm { get; set; } 
    #endif
    
    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("_UBYIx9p-Ed-ak6NoX_4Aeg_-790353691")]
    [DisplayName("Signature Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrTp")]
    #endif
    [IsoXmlTag("SgntrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignatureType1Code SignatureType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SignatureType1Code SignatureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignatureType1Code SignatureType { get; init; } 
    #else
    public SignatureType1Code SignatureType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
