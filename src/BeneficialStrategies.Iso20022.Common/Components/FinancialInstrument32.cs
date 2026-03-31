// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_4iWTgRgGEeKqWJINzXcn5g")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument32
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_43grORgGEeKqWJINzXcn5g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_43grPRgGEeKqWJINzXcn5g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument is transferred as an asset or as cash.
    /// </summary>
    [IsoId("_A0GAdScfEeK33eWt3gq4Fg")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType1Code TransferType { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_43grQRgGEeKqWJINzXcn5g")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account6? TransfereeAccount { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("__FPYyhgGEeKqWJINzXcn5g")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("__FPYzxgGEeKqWJINzXcn5g")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; }
}
