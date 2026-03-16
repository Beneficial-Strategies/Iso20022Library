// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of the certificate data set.
/// </summary>
[IsoId("_TnmW1tp-Ed-ak6NoX_4Aeg_-1858308306")]
[DisplayName("Required Submission")]
public record RequiredSubmission4
{
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_TnmW19p-Ed-ak6NoX_4Aeg_-1858308280")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public ValueList<BICIdentification1> Submitter { get; init; } = [];

    // ID for the above is _TnmW19p-Ed-ak6NoX_4Aeg_-1858308280

    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_TnmW2Np-Ed-ak6NoX_4Aeg_-150714604")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    public required TradeCertificateType1Code CertificateType { get; init; }

    /// <summary>
    /// Specifies if the issuer must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH0Np-Ed-ak6NoX_4Aeg_1034550595")]
    [DisplayName("Match Issuer")]
    [IsoXmlTag("MtchIssr")]
    public PartyIdentification27? MatchIssuer { get; init; }

    /// <summary>
    /// Specifies if the issue date must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH0dp-Ed-ak6NoX_4Aeg_-530283967")]
    [DisplayName("Match Issue Date")]
    [IsoXmlTag("MtchIsseDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MatchIssueDate { get; init; }

    /// <summary>
    /// Specifies if the inspection date must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH0tp-Ed-ak6NoX_4Aeg_-523817028")]
    [DisplayName("Match Inspection Date")]
    [IsoXmlTag("MtchInspctnDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MatchInspectionDate { get; init; }

    /// <summary>
    /// Specifies if the indication of an authorised inspector must be present as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH09p-Ed-ak6NoX_4Aeg_-456402441")]
    [DisplayName("Authorised Inspector Indicator")]
    [IsoXmlTag("AuthrsdInspctrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AuthorisedInspectorIndicator { get; init; }

    /// <summary>
    /// Specifies if the consignee must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH1Np-Ed-ak6NoX_4Aeg_-198739488")]
    [DisplayName("Match Consignee")]
    [IsoXmlTag("MtchConsgn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MatchConsignee { get; init; }

    /// <summary>
    /// Specifies if the manufacturer must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_TnwH1dp-Ed-ak6NoX_4Aeg_99351627")]
    [DisplayName("Match Manufacturer")]
    [IsoXmlTag("MtchManfctr")]
    public PartyIdentification27? MatchManufacturer { get; init; }

    /// <summary>
    /// Specifies if the certificate data set is required in relation to specific line items, and which line items.
    /// </summary>
    [IsoId("_TnwH1tp-Ed-ak6NoX_4Aeg_161434273")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? LineItemIdentification { get; init; }
}
