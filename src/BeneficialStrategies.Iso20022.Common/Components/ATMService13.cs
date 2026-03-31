// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit service provided by the ATM inside the session.
/// </summary>
[IsoId("_4TAcsa4OEeWZgJQOa6iKCQ")]
[DisplayName("ATM Service")]
public record ATMService13
{
    /// <summary>
    /// Unique identification of the deposit service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_4dlVAa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; }

    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_4dlVA64OEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; }

    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_4dlVBa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; }

    /// <summary>
    /// Describes the type of deposit service selected by the customer.
    /// </summary>
    [IsoId("_4dlVB64OEeWZgJQOa6iKCQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType6Code ServiceType { get; init; }

    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_4dlVCa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    public SimpleValueList<IsoMax35Text> ServiceVariantIdentification { get; init; } = [];

    /// <summary>
    /// True if deposit with cash back transaction.
    /// </summary>
    [IsoId("_4dlVC64OEeWZgJQOa6iKCQ")]
    [DisplayName("Cash Back")]
    [IsoXmlTag("CshBck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CashBack { get; init; }

    /// <summary>
    /// True if the deposit transaction is split in multiple accounts.
    /// </summary>
    [IsoId("_4dlVDa4OEeWZgJQOa6iKCQ")]
    [DisplayName("Multi Account")]
    [IsoXmlTag("MultiAcct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MultiAccount { get; init; }

    /// <summary>
    /// True if this is not the final deposit.
    /// </summary>
    [IsoId("_BovdAK4PEeWZgJQOa6iKCQ")]
    [DisplayName("Partial Deposit")]
    [IsoXmlTag("PrtlDpst")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialDeposit { get; init; }
}
