// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy.
/// </summary>
[IsoId("cd6a8d35-09a3-4c0d-acdf-b6f980205470")]
[DisplayName("Financial Instrument116")]
public record FinancialInstrument116
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("ad046d1f-eabe-4a99-8751-5434759b31a8")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification46Choice Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("15b4721c-acae-408e-97ae-14af0960bdf8")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("966b7cbe-5f61-429c-9db2-eb1c46dc4b33")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("b2355b5f-c005-4145-94d3-b3b93b43cb73")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Features of units offered by a fund.
    /// </summary>
    [IsoId("7192a5ea-e436-4fff-9f7e-fd65eac519da")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security.
    /// </summary>
    [IsoId("2ad680c0-443d-441e-8192-5675ba428c13")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Income policy relating to a class type.
    /// </summary>
    [IsoId("644f7715-913c-4cf4-bc71-b8f6b20fead4")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record.
    /// </summary>
    [IsoId("cc3140e0-e332-4718-bb39-906e25e64762")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }
}
