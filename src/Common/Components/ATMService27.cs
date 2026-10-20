// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Service27.
/// </summary>
[IsoId("_uCK00Z9aEe-nbM0aSPcoiQ")]
[DisplayName("ATM Service27")]
public partial record ATMService27
{
    /// <summary>
    /// Service Reference.
    /// </summary>
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    public Max35Text? ServiceReference { get; init; }

    /// <summary>
    /// ATM Service Code.
    /// </summary>
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    public Max35Text? ATMServiceCode { get; init; }

    /// <summary>
    /// Host Service Code.
    /// </summary>
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    public Max35Text? HostServiceCode { get; init; }

    /// <summary>
    /// Service Type.
    /// </summary>
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType11Code ServiceType { get; init; }

    /// <summary>
    /// Service Variant Identification.
    /// </summary>
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    public ValueList<Max35Text> ServiceVariantIdentification { get; init; } = [];
}
