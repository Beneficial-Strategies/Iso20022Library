// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the narrative type of a corporate action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bK2F0Np-Ed-ak6NoX_4Aeg_24208784")]
[Description(@"Specifies the narrative type of a corporate action.")]
[DerivedFrom(typeof(CorporateActionNarrativeCode))]
public enum CorporateActionNarrative1Code
{
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_bK2F0dp-Ed-ak6NoX_4Aeg_24208786")]
    [Description(@"Provides taxation conditions that cannot be included within the structured fields of this message.")]
    TaxationConditions = CorporateActionNarrativeCode.TaxationConditions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provides information required for the registration.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_bK2F0tp-Ed-ak6NoX_4Aeg_24208815")]
    [Description(@"Provides information required for the registration.")]
    RegistrationDetails = CorporateActionNarrativeCode.RegistrationDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certification process for withholding tax reduction or exemption based on the tax status of the holder.
    /// Encoded/decoded by serializers as &quot;WTRC&quot;.
    /// </summary>
    [EnumMember(Value = "WTRC")]
    [IsoId("_bK2F09p-Ed-ak6NoX_4Aeg_24209063")]
    [Description(@"Certification process for withholding tax reduction or exemption based on the tax status of the holder.")]
    WithholdingTaxReliefCertification = CorporateActionNarrativeCode.WithholdingTaxReliefCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In the context of a corporate action, an International Central Securities Depository (ICSD) refuses a mark-up/mark-down confirmation sent by the account servicer.
    /// Encoded/decoded by serializers as &quot;RFMC&quot;.
    /// </summary>
    [EnumMember(Value = "RFMC")]
    [IsoId("_bK2F1Np-Ed-ak6NoX_4Aeg_24209085")]
    [Description(@"In the context of a corporate action, an International Central Securities Depository (ICSD) refuses a mark-up/mark-down confirmation sent by the account servicer.")]
    ICSDRefusalOfMarkUpDownConfirmation = CorporateActionNarrativeCode.ICSDRefusalOfMarkUpDownConfirmation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// International Central Securities Depository (ICSD) chases the authorisation from the account servicer in order to process the exchange from global temporary to global permanent.
    /// Encoded/decoded by serializers as &quot;PAUT&quot;.
    /// </summary>
    [EnumMember(Value = "PAUT")]
    [IsoId("_bK2F1dp-Ed-ak6NoX_4Aeg_24209116")]
    [Description(@"International Central Securities Depository (ICSD) chases the authorisation from the account servicer in order to process the exchange from global temporary to global permanent.")]
    ChasingOfPriorAuthorization = CorporateActionNarrativeCode.ChasingOfPriorAuthorization, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confirmation of transfer of interests between International Central Securities Depositories (ICSDs) following a corporate actions.
    /// Encoded/decoded by serializers as &quot;CTIN&quot;.
    /// </summary>
    [EnumMember(Value = "CTIN")]
    [IsoId("_bK2F1tp-Ed-ak6NoX_4Aeg_24209125")]
    [Description(@"Confirmation of transfer of interests between International Central Securities Depositories (ICSDs) following a corporate actions.")]
    ConfirmationOfHoldingTransfer = CorporateActionNarrativeCode.ConfirmationOfHoldingTransfer, // same ordinal as derivation source for type conversions
    
}
