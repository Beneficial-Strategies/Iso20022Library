// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transactions reported.
/// </summary>
[IsoId("_M9-J0Ss9EeySlt9bF77XfA")]
[DisplayName("Transaction")]
public record Transaction124
{
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_NVOMNSs9EeySlt9bF77XfA")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the triparty-agent/service-provider collateral management transaction from the triparty-agent&apos;s/service-provider&apos;s point of view.
    /// </summary>
    [IsoId("_NVOMNys9EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique collateral transaction reference assigned by counterparty.
    /// </summary>
    [IsoId("_NVOMOSs9EeySlt9bF77XfA")]
    [DisplayName("Counterparty Collateral Transaction Reference")]
    [IsoXmlTag("CtrPtyCollTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CounterpartyCollateralTransactionReference { get; init; }

    /// <summary>
    /// Unique identification (UTI) agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_NVOMOys9EeySlt9bF77XfA")]
    [DisplayName("Common Transaction Identification")]
    [IsoXmlTag("CmonTxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? CommonTransactionIdentification { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_NVOMPSs9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType23Choice_ ExposureType { get; init; }

    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_NVOMPys9EeySlt9bF77XfA")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType6Choice_? OptionType { get; init; }

    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable repo.
    /// </summary>
    [IsoId("_NVOMQSs9EeySlt9bF77XfA")]
    [DisplayName("Termination Option")]
    [IsoXmlTag("TermntnOptn")]
    public RepoTerminationOption1Code? TerminationOption { get; init; }

    /// <summary>
    /// Provides information on the baskets identification and the Eligiblity Set Profile.
    /// </summary>
    [IsoId("_NVOMQys9EeySlt9bF77XfA")]
    [DisplayName("Basket Identification And Eligibility Set Profile")]
    [IsoXmlTag("BsktIdAndElgbltySetPrfl")]
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; init; }

    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_NVOMRSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties11 CollateralParties { get; init; }

    /// <summary>
    /// Date/time at which the party requested the initiation instruction to be executed.
    /// </summary>
    [IsoId("_NVOMRys9EeySlt9bF77XfA")]
    [DisplayName("Execution Requested Date")]
    [IsoXmlTag("ExctnReqdDt")]
    public required ClosingDate4Choice_ ExecutionRequestedDate { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_NVOMSSs9EeySlt9bF77XfA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public required ClosingDate4Choice_ ClosingDate { get; init; }

    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_NVOMSys9EeySlt9bF77XfA")]
    [DisplayName("Valuation Amounts")]
    [IsoXmlTag("ValtnAmts")]
    public required CollateralAmount17 ValuationAmounts { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_NVOMTSs9EeySlt9bF77XfA")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName4Choice_? PricingRate { get; init; }

    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_NVOMTys9EeySlt9bF77XfA")]
    [DisplayName("Margin Rate")]
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MarginRate { get; init; }

    /// <summary>
    /// Margin rate over or under an index.
    /// Feedback
    /// </summary>
    [IsoId("_NVOMUSs9EeySlt9bF77XfA")]
    [DisplayName("Spread Rate")]
    [IsoXmlTag("SprdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? SpreadRate { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_NVOMUys9EeySlt9bF77XfA")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies whether the allocation of the collateral is manual or automatic.
    /// </summary>
    [IsoId("_NVOMVSs9EeySlt9bF77XfA")]
    [DisplayName("Automatic Allocation")]
    [IsoXmlTag("AutomtcAllcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AutomaticAllocation { get; init; }

    /// <summary>
    /// Provides the status of a  transaction.
    /// </summary>
    [IsoId("_NVOMVys9EeySlt9bF77XfA")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<TransactionStatus6> TransactionStatus { get; init; } = [];

    /// <summary>
    /// Quantity of securities assigned as collateral position.
    /// </summary>
    [IsoId("_NVOMWSs9EeySlt9bF77XfA")]
    [DisplayName("Securities Balance")]
    [IsoXmlTag("SctiesBal")]
    public ValueList<SecuritiesBalance3> SecuritiesBalance { get; init; } = [];

    /// <summary>
    /// Amount of cash assigned as collateral position.
    /// </summary>
    [IsoId("_NVOMWys9EeySlt9bF77XfA")]
    [DisplayName("Cash Balance")]
    [IsoXmlTag("CshBal")]
    public ValueList<CashBalance15> CashBalance { get; init; } = [];
}
