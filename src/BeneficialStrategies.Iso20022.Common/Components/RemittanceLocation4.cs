// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceLocation4"/>
[IsoId("_jmoAoSFBEeSko9Nh5NKf8Q")]
[DisplayName("Remittance Location")]
public partial record RemittanceLocation4
{
    /// <inheritdoc cref="IRemittanceLocation4.RemittanceIdentification"/>
    [IsoId("_qah9YyFBEeSko9Nh5NKf8Q")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <inheritdoc cref="IRemittanceLocation4.RemittanceLocationDetails"/>
    [IsoId("_qah9ZCFBEeSko9Nh5NKf8Q")]
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationDetails1> RemittanceLocationDetails { get; init; } = [];
}
