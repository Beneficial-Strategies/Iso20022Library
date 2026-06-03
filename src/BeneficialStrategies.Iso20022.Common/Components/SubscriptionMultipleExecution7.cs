// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
[IsoId("ea4813b0-c4d4-476f-866a-f03d07723258")]
[DisplayName("Subscription Multiple Execution7")]
public record SubscriptionMultipleExecution7
{
    [IsoId("323a0eb6-e15b-4de9-9ec7-48e975229e5d")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    [IsoId("1b078b69-8cde-463d-9e20-b0d5cc554dc4")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    [IsoId("47e9afbc-8374-42db-8aba-61b88c05066f")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    [IsoId("fe68da0b-4e77-4149-962d-2bab7480aaa2")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    [IsoId("497dbd82-2a4d-40cf-a58e-d4029c951253")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    [IsoId("3fb689c1-83d0-4784-b08d-66674cac399f")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    [IsoId("489e5a78-be92-4c71-9060-cf0784cc3977")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    [IsoId("67fefbfc-9a94-481e-88d1-7922322a81ad")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount81 InvestmentAccountDetails { get; init; }

    [IsoId("6f1ef1af-35ab-4b31-b456-947ce486996c")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson32> BeneficiaryDetails { get; init; } = [];

    [IsoId("de795a98-5878-46f1-bce9-e06a8076e6cb")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    [MinLength(1)]
    public ValueList<SubscriptionExecution16> IndividualExecutionDetails { get; init; } = [];

    [IsoId("ad8df7ac-20f4-44d0-b532-18697ab8ecfa")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    [IsoId("5b932be1-5e79-48d1-81f4-b6b55a3d181f")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction180? BulkCashSettlementDetails { get; init; }
}
