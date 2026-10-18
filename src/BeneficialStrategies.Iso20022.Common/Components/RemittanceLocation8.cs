// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceLocation8"/>
[IsoId("_0IULUTEyEe6g-ffJsqGiSA")]
[Description(@"Provides information on the remittance advice.")]
[DisplayName("Remittance Location8")]
public partial record RemittanceLocation8
{
    /// <inheritdoc cref="IRemittanceLocation8.RemittanceIdentification"/>
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <inheritdoc cref="IRemittanceLocation8.RemittanceLocationDetails"/>
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationData2> RemittanceLocationDetails { get; init; } = [];
}
