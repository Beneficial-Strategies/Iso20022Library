// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice;

/// <summary>
/// Unique and unambiguous identification of a financial institution, through a combimation of globally recognised or proprietary identification scheme.
/// </summary>
[IsoId("_TFnrItp-Ed-ak6NoX_4Aeg_1781480692")]
public interface ICombinedIdentification : IFinancialInstitutionIdentification5Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_TFehMdp-Ed-ak6NoX_4Aeg_696920663")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    BICIdentifier? BIC { get; }

    /// <summary>
    /// Unique and unambiguous identifier of a clearing system member, as assigned by the system or system administrator.
    /// </summary>
    [IsoId("_TFehMtp-Ed-ak6NoX_4Aeg_696921670")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    IClearingSystemMemberIdentification3Choice? ClearingSystemMemberIdentification { get; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_TFehM9p-Ed-ak6NoX_4Aeg_696922156")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max70Text? Name { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_TFehNNp-Ed-ak6NoX_4Aeg_696923981")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress1? PostalAddress { get; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_TFehNdp-Ed-ak6NoX_4Aeg_-1274464914")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    IGenericIdentification3? ProprietaryIdentification { get; }
}
