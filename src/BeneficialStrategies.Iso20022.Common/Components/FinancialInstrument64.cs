// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_Kg3Qsa5zEeeMy7TnJ3e__g")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument64
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_KvvaNa5zEeeMy7TnJ3e__g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification25Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_KvvaN65zEeeMy7TnJ3e__g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_KvvaOa5zEeeMy7TnJ3e__g")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_KvvaO65zEeeMy7TnJ3e__g")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account24? TransfereeAccount { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("_KvvaPa5zEeeMy7TnJ3e__g")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }
}
