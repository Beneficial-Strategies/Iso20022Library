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
/// Provides additional information about the delivery details, beneficial owner details, etc.
/// </summary>
[IsoId("_UMZtCNp-Ed-ak6NoX_4Aeg_302800554")]
[DisplayName("Corporate Action Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAdditionalInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the beneficial owner of the securities.
    /// </summary>
    [IsoId("_UMjeANp-Ed-ak6NoX_4Aeg_-2045712044")]
    [DisplayName("Beneficial Owner Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrDtls")]
    #endif
    [IsoXmlTag("BnfclOwnrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficialOwner1? BeneficialOwnerDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficialOwner1? BeneficialOwnerDetails { get; init; } 
    #else
    public BeneficialOwner1? BeneficialOwnerDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_UMjeAdp-Ed-ak6NoX_4Aeg_-1779080684")]
    [DisplayName("Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDtls")]
    #endif
    [IsoXmlTag("RegnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? RegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationDetails { get; init; } 
    #else
    public System.String? RegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the receiver of outturned resources (cash/securities) in case the resources need to be delivered outside the CSD.
    /// </summary>
    [IsoId("_UMjeAtp-Ed-ak6NoX_4Aeg_-1632874072")]
    [DisplayName("Receiver Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrId")]
    #endif
    [IsoXmlTag("RcvrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? ReceiverIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? ReceiverIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? ReceiverIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Whether or not certification is required from the account owner. |Y: certification required |N: no certification required.
    /// </summary>
    [IsoId("_UMjeA9p-Ed-ak6NoX_4Aeg_-1477351985")]
    [DisplayName("Certification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnInd")]
    #endif
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationIndicator { get; init; } 
    #else
    public System.String? CertificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_UMjeBNp-Ed-ak6NoX_4Aeg_-1477351955")]
    [DisplayName("Certification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnTp")]
    #endif
    [IsoXmlTag("CertfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #else
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the delivery details of proceeds.
    /// </summary>
    [IsoId("_UMjeBdp-Ed-ak6NoX_4Aeg_138497699")]
    [DisplayName("Delivery Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDtls")]
    #endif
    [IsoXmlTag("DlvryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProceedsDelivery1? DeliveryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProceedsDelivery1? DeliveryDetails { get; init; } 
    #else
    public ProceedsDelivery1? DeliveryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details pertaining to the corporate action instruction.
    /// </summary>
    [IsoId("_UMjeBtp-Ed-ak6NoX_4Aeg_1410048508")]
    [DisplayName("Additional Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInstr")]
    #endif
    [IsoXmlTag("AddtlInstr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInstruction { get; init; } 
    #else
    public System.String? AdditionalInstruction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
