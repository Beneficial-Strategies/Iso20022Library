// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specifying the Mandate.
/// </summary>
[IsoId("_PU0TCNp-Ed-ak6NoX_4Aeg_882485355")]
[DisplayName("Operation Mandate")]
public record OperationMandate1
{
    /// <summary>
    /// Unique and unambiguous identification of the mandate.
    /// </summary>
    [IsoId("_PU0TCdp-Ed-ak6NoX_4Aeg_-722803781")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Number of required and necessary signatures by the mandate.
    /// </summary>
    [IsoId("_PU0TCtp-Ed-ak6NoX_4Aeg_282782805")]
    [DisplayName("Required Signature Number")]
    [IsoXmlTag("ReqrdSgntrNb")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; }

    /// <summary>
    /// Indicator whether a certain order of signatures has to be respected or not.
    /// </summary>
    [IsoId("_PU0TC9p-Ed-ak6NoX_4Aeg_314180071")]
    [DisplayName("Signature Order Indicator")]
    [IsoXmlTag("SgntrOrdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; }

    /// <summary>
    /// Holder of the mandate.
    /// </summary>
    [IsoId("_PU0TDNp-Ed-ak6NoX_4Aeg_-1242081229")]
    [DisplayName("Mandate Holder")]
    [IsoXmlTag("MndtHldr")]
    public ValueList<PartyAndCertificate1> MandateHolder { get; init; } = [];

    /// <summary>
    /// Bank operation allowed by a mandate.
    /// </summary>
    [IsoId("_PU0TDdp-Ed-ak6NoX_4Aeg_-375361255")]
    [DisplayName("Bank Operation")]
    [IsoXmlTag("BkOpr")]
    public ValueList<BankTransactionCodeStructure4> BankOperation { get; init; } = [];

    // ID for the above is _PU0TDdp-Ed-ak6NoX_4Aeg_-375361255

    /// <summary>
    /// Is the date when the mandate becomes valid.
    /// </summary>
    [IsoId("_PU0TDtp-Ed-ak6NoX_4Aeg_-1787248680")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Is the date when the mandate stops to be valid.
    /// </summary>
    [IsoId("_PU-EANp-Ed-ak6NoX_4Aeg_-1712030691")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }
}
