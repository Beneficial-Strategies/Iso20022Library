// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on standing orders.
/// </summary>
[IsoId("_72-v8aMgEeCJ6YNENx4h-w_1129668542")]
[DisplayName("Standing Order Return Criteria")]
public record StandingOrderReturnCriteria1
{
    /// <summary>
    /// Defines the criteria used to report on a multilateral balance.
    /// </summary>
    [IsoId("_72-v8qMgEeCJ6YNENx4h-w_1131789573")]
    [DisplayName("Standing Order Identification Indicator")]
    [IsoXmlTag("StgOrdrIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StandingOrderIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the standing order type is requested.
    /// </summary>
    [IsoId("_72-v86MgEeCJ6YNENx4h-w_-1572131023")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TypeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the system member identification is requested.
    /// </summary>
    [IsoId("_72-v9KMgEeCJ6YNENx4h-w_2068552367")]
    [DisplayName("System Member Indicator")]
    [IsoXmlTag("SysMmbInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SystemMemberIndicator { get; init; }

    /// <summary>
    /// Indicates whether the responsible party identification is requested.
    /// </summary>
    [IsoId("_72-v9aMgEeCJ6YNENx4h-w_-1772327660")]
    [DisplayName("Responsible Party Indicator")]
    [IsoXmlTag("RspnsblPtyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ResponsiblePartyIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_72-v9qMgEeCJ6YNENx4h-w_58595509")]
    [DisplayName("Currency Indicator")]
    [IsoXmlTag("CcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CurrencyIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_73H54KMgEeCJ6YNENx4h-w_512682778")]
    [DisplayName("Debtor Account Indicator")]
    [IsoXmlTag("DbtrAcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? DebtorAccountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the multilateral limit is requested.
    /// </summary>
    [IsoId("_73H54aMgEeCJ6YNENx4h-w_501584001")]
    [DisplayName("Creditor Account Indicator")]
    [IsoXmlTag("CdtrAcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditorAccountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the associated pool account is requested.
    /// </summary>
    [IsoId("_73H54qMgEeCJ6YNENx4h-w_-721838563")]
    [DisplayName("Associated Pool Account")]
    [IsoXmlTag("AssoctdPoolAcct")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AssociatedPoolAccount { get; init; }

    /// <summary>
    /// Indicates whether the frequency is requested.
    /// </summary>
    [IsoId("_73H546MgEeCJ6YNENx4h-w_942244873")]
    [DisplayName("Frequency Indicator")]
    [IsoXmlTag("FrqcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? FrequencyIndicator { get; init; }

    /// <summary>
    /// Indicates whether the execution type is requested.
    /// </summary>
    [IsoId("_73H55KMgEeCJ6YNENx4h-w_-291151916")]
    [DisplayName("Execution Type Indicator")]
    [IsoXmlTag("ExctnTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ExecutionTypeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_73H55aMgEeCJ6YNENx4h-w_1111985929")]
    [DisplayName("Validity From Indicator")]
    [IsoXmlTag("VldtyFrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ValidityFromIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account owner information is requested.
    /// </summary>
    [IsoId("_73H55qMgEeCJ6YNENx4h-w_-886872152")]
    [DisplayName("Valid To Indicator")]
    [IsoXmlTag("VldToInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ValidToIndicator { get; init; }

    /// <summary>
    /// Indicates whether the link set identification is requested.
    /// </summary>
    [IsoId("_73H556MgEeCJ6YNENx4h-w_-897970929")]
    [DisplayName("Link Set Identification Indicator")]
    [IsoXmlTag("LkSetIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? LinkSetIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the identification of a standing order within a link set is requested.
    /// </summary>
    [IsoId("_73Rq4KMgEeCJ6YNENx4h-w_1831649883")]
    [DisplayName("Link Set Order Identification Indicator")]
    [IsoXmlTag("LkSetOrdrIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? LinkSetOrderIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the sequence of a standing order within a link set is requested.
    /// </summary>
    [IsoId("_73Rq4aMgEeCJ6YNENx4h-w_834577530")]
    [DisplayName("Link Set Order Sequence Indicator")]
    [IsoXmlTag("LkSetOrdrSeqInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? LinkSetOrderSequenceIndicator { get; init; }

    /// <summary>
    /// Indicates whether the total amount per standing order type is requested.
    /// </summary>
    [IsoId("_73Rq4qMgEeCJ6YNENx4h-w_175820900")]
    [DisplayName("Total Amount Indicator")]
    [IsoXmlTag("TtlAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TotalAmountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the zero sweeping indicator is requested.
    /// </summary>
    [IsoId("_73Rq46MgEeCJ6YNENx4h-w_1186558213")]
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ZeroSweepIndicator { get; init; }
}
