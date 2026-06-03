// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the settlement obligation.
/// </summary>
[IsoId("_-e889qMOEeCojJW5vEuTEQ_908473002")]
[DisplayName("Settlement Obligation6")]
[Obsolete]
public record SettlementObligation6
{
    [IsoId("_-e8896MOEeCojJW5vEuTEQ_794633936")]
    [DisplayName("CSD Transaction Identification")]
    [IsoXmlTag("CSDTxId")]
    public IsoMax35Text? CSDTransactionIdentification { get; init; }

    [IsoId("_-fGG4KMOEeCojJW5vEuTEQ_-202438417")]
    [DisplayName("Central Counterparty Transaction Identification")]
    [IsoXmlTag("CntrlCtrPtyTxId")]
    public IsoMax35Text? CentralCounterpartyTransactionIdentification { get; init; }

    [IsoId("_-fGG4aMOEeCojJW5vEuTEQ_-1199510770")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    [IsoId("_-fGG4qMOEeCojJW5vEuTEQ_2098384173")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_-fGG46MOEeCojJW5vEuTEQ_-1427673033")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification35Choice? ClearingSegment { get; init; }

    [IsoId("_-fGG5KMOEeCojJW5vEuTEQ_1870221910")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; }

    [IsoId("_-fGG5aMOEeCojJW5vEuTEQ_873149557")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public IsoISODate? IntendedSettlementDate { get; init; }

    [IsoId("_-fGG5qMOEeCojJW5vEuTEQ_-123922796")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    [IsoId("_-fGG56MOEeCojJW5vEuTEQ_-1120995149")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public IsoISODate? TradeDate { get; init; }

    [IsoId("_-fGG6KMOEeCojJW5vEuTEQ_-2118067502")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price4? DealPrice { get; init; }

    [IsoId("_-fP34KMOEeCojJW5vEuTEQ_1179827441")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice Quantity { get; init; }

    [IsoId("_-fP34aMOEeCojJW5vEuTEQ_182755088")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification34Choice? Depository { get; init; }

    [IsoId("_-fP34qMOEeCojJW5vEuTEQ_-814317265")]
    [DisplayName("Remaining Quantity To Be Settled")]
    [IsoXmlTag("RmngQtyToBeSttld")]
    public FinancialInstrumentQuantity1Choice? RemainingQuantityToBeSettled { get; init; }

    [IsoId("_-fP346MOEeCojJW5vEuTEQ_-1811389618")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; }

    [IsoId("_-fP35KMOEeCojJW5vEuTEQ_1563544026")]
    [DisplayName("Remaining Amount To Be Settled")]
    [IsoXmlTag("RmngAmtToBeSttld")]
    public AmountAndDirection27? RemainingAmountToBeSettled { get; init; }
}
