// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the settlement fails split per instruction types.
/// </summary>
[IsoId("_MSd6hTOmEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily Instruction Type")]
public partial record SettlementFailsDailyInstructionType3
{
    #nullable enable
    
    /// <summary>
    /// Fails due to delivery versus payment (DVP) settlement transactions, covers both delivery versus payment and receive versus payment transactions. 
    /// </summary>
    [IsoId("_MTNhYTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Delivery Versus Payment")]
    [IsoXmlTag("DlvryVrssPmt")]
    public required SettlementDailyFailureReason1Choice_ DeliveryVersusPayment { get; init; } 
    
    /// <summary>
    /// Fails due to delivery with payment (DWP) settlement transactions, covers both delivery with payment (DWP) and receive with payment (RWP) transactions. 
    /// </summary>
    [IsoId("_MTNhYzOmEeqX8uoQQ3KffQ")]
    [DisplayName("Delivery With Payment")]
    [IsoXmlTag("DlvryWthPmt")]
    public required SettlementDailyFailureReason1Choice_ DeliveryWithPayment { get; init; } 
    
    /// <summary>
    /// Fails due to payment free of delivery (PFOD) settlement transactions, covers both debit payment free of delivery (DPFOD) and credit payment free of delivery (CPFOD) transactions.
    /// </summary>
    [IsoId("_MTNhZTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Payment Free Of Delivery")]
    [IsoXmlTag("PmtFreeOfDlvry")]
    public required SettlementDailyFailureReason1Choice_ PaymentFreeOfDelivery { get; init; } 
    
    /// <summary>
    /// Fails due to free of payment (FoP) settlement transactions, covers both deliver free of payment (DFoP) and receive free of payment (RFoP) transactions.
    /// </summary>
    [IsoId("_MTNhZzOmEeqX8uoQQ3KffQ")]
    [DisplayName("Free Of Payment")]
    [IsoXmlTag("FreeOfPmt")]
    public required SettlementDailyFailureReason1Choice_ FreeOfPayment { get; init; } 
    
    
    #nullable disable
    
}
