// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Standard code to specify the narrative type of a corporate action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bK2F19p-Ed-ak6NoX_4Aeg_-1191141683")]
[Description(@"Standard code to specify the narrative type of a corporate action.")]
[Derivations(typeof(CorporateActionNarrative1Code))]
public enum CorporateActionNarrativeCode
{
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_bK2F2Np-Ed-ak6NoX_4Aeg_-923322797")]
    [Description(@"Provides taxation conditions that cannot be included within the structured fields of this message.")]
    TaxationConditions,
    
    /// <summary>
    /// Provides information required for the registration.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_bK_PwNp-Ed-ak6NoX_4Aeg_-821735207")]
    [Description(@"Provides information required for the registration.")]
    RegistrationDetails,
    
    /// <summary>
    /// Certification process for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("_bK_Pwdp-Ed-ak6NoX_4Aeg_-45055291")]
    [Description(@"Certification process for withholding tax reduction or exemption based on the tax status of the holder.")]
    WithholdingTaxReliefCertification,
    
    /// <summary>
    /// In the context of a corporate action, an International Central Securities Depository (ICSD) refuses a mark-up/mark-down confirmation sent by the account servicer.
    /// Encoded/decoded by serializers as &quot;RFMC&quot;.
    /// </summary>
    [EnumMember(Value = "RFMC")]
    [IsoId("_bK_Pwtp-Ed-ak6NoX_4Aeg_-548371520")]
    [Description(@"In the context of a corporate action, an International Central Securities Depository (ICSD) refuses a mark-up/mark-down confirmation sent by the account servicer.")]
    ICSDRefusalOfMarkUpDownConfirmation,
    
    /// <summary>
    /// International Central Securities Depository (ICSD) chases the authorisation from the account servicer in order to process the exchange from global temporary to global permanent.
    /// Encoded/decoded by serializers as &quot;PAUT&quot;.
    /// </summary>
    [EnumMember(Value = "PAUT")]
    [IsoId("_bK_Pw9p-Ed-ak6NoX_4Aeg_-531750931")]
    [Description(@"International Central Securities Depository (ICSD) chases the authorisation from the account servicer in order to process the exchange from global temporary to global permanent.")]
    ChasingOfPriorAuthorization,
    
    /// <summary>
    /// Confirmation of transfer of interests between International Central Securities Depositories (ICSDs) following a corporate actions.
    /// Encoded/decoded by serializers as &quot;CTIN&quot;.
    /// </summary>
    [EnumMember(Value = "CTIN")]
    [IsoId("_bK_PxNp-Ed-ak6NoX_4Aeg_-515127060")]
    [Description(@"Confirmation of transfer of interests between International Central Securities Depositories (ICSDs) following a corporate actions.")]
    ConfirmationOfHoldingTransfer,
    
}
