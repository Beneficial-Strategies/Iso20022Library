// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that enables any payments made in connection with the fulfilment of an account switch to be reconciled by the relevant account servicer with the associated request.
/// </summary>
[IsoId("_PdFGAcQAEemsic1bQcEtLA")]
[DisplayName("Balance Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceTransfer3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that enables the creditor to reconcile a payment received through a different payment channel with the payment request.
    /// </summary>
    [IsoId("_Po-M8cQAEemsic1bQcEtLA")]
    [DisplayName("Balance Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrfRef")]
    #endif
    [IsoXmlTag("BalTrfRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceTransferReference1? BalanceTransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceTransferReference1? BalanceTransferReference { get; init; } 
    #else
    public BalanceTransferReference1? BalanceTransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Contains details of the clearance and settlement method chosen to make the appropriate payment from account servicer to account servicer in order to transfer the positive or negative closing balance of the old account to the new account.
    /// </summary>
    [IsoId("_Po-M88QAEemsic1bQcEtLA")]
    [DisplayName("Balance Transfer Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrfMtd")]
    #endif
    [IsoXmlTag("BalTrfMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementMethod3Choice_? BalanceTransferMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementMethod3Choice_? BalanceTransferMethod { get; init; } 
    #else
    public SettlementMethod3Choice_? BalanceTransferMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum value that the new account servicer will pay to the old account servicer when the closing balance on the old account is negative.
    /// </summary>
    [IsoId("_Po-M9cQAEemsic1bQcEtLA")]
    [DisplayName("Balance Transfer Funding Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrfFndgLmt")]
    #endif
    [IsoXmlTag("BalTrfFndgLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; } 
    #else
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
