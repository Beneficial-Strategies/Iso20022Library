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
/// Provides further specific details on the direct debit transaction and the related mandate.
/// </summary>
[IsoId("_teOIFFkyEeGeoaLUQk__nA_-44186302")]
[DisplayName("Direct Debit Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DirectDebitTransaction7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides further details of the direct debit mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_teX5EFkyEeGeoaLUQk__nA_1642774080")]
    [DisplayName("Mandate Related Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtRltdInf")]
    #endif
    [IsoXmlTag("MndtRltdInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateRelatedInformation8? MandateRelatedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateRelatedInformation8? MandateRelatedInformation { get; init; } 
    #else
    public MandateRelatedInformation8? MandateRelatedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_teX5EVkyEeGeoaLUQk__nA_-507772793")]
    [DisplayName("Creditor Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrSchmeId")]
    #endif
    [IsoXmlTag("CdtrSchmeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification43? CreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the pre-notification which is sent separately from the direct debit instruction.||Usage: The direct debit pre-notification is used to reconcile separately sent collection information with the direct debit transaction information.
    /// </summary>
    [IsoId("_teX5ElkyEeGeoaLUQk__nA_63774911")]
    [DisplayName("Pre Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreNtfctnId")]
    #endif
    [IsoXmlTag("PreNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PreNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreNotificationIdentification { get; init; } 
    #else
    public System.String? PreNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the creditor notifies the debtor about the amount and date on which the direct debit instruction will be presented to the debtor&apos;s agent.
    /// </summary>
    [IsoId("_teX5E1kyEeGeoaLUQk__nA_-1935083170")]
    [DisplayName("Pre Notification Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreNtfctnDt")]
    #endif
    [IsoXmlTag("PreNtfctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PreNotificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PreNotificationDate { get; init; } 
    #else
    public System.DateOnly? PreNotificationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
