// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceLocation2"/>
[IsoId("_QF_4Udp-Ed-ak6NoX_4Aeg_-1849801133")]
[DisplayName("Remittance Location")]
public partial record RemittanceLocation2
{
    /// <inheritdoc cref="IRemittanceLocation2.RemittanceIdentification"/>
    [IsoId("_QF_4Utp-Ed-ak6NoX_4Aeg_-1849800824")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <inheritdoc cref="IRemittanceLocation2.RemittanceLocationMethod"/>
    [IsoId("_QF_4U9p-Ed-ak6NoX_4Aeg_-1849801131")]
    [DisplayName("Remittance Location Method")]
    [IsoXmlTag("RmtLctnMtd")]
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; init; }

    /// <inheritdoc cref="IRemittanceLocation2.RemittanceLocationElectronicAddress"/>
    [IsoId("_QF_4VNp-Ed-ak6NoX_4Aeg_-1849800855")]
    [DisplayName("Remittance Location Electronic Address")]
    [IsoXmlTag("RmtLctnElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? RemittanceLocationElectronicAddress { get; init; }

    /// <inheritdoc cref="IRemittanceLocation2.RemittanceLocationPostalAddress"/>
    [IsoId("_QF_4Vdp-Ed-ak6NoX_4Aeg_-1849800718")]
    [DisplayName("Remittance Location Postal Address")]
    [IsoXmlTag("RmtLctnPstlAdr")]
    public NameAndAddress10? RemittanceLocationPostalAddress { get; init; }
}
