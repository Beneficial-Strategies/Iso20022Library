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
/// Cash settlement parties and accounts.
/// </summary>
[IsoId("_OfaugSC3EeWJd9HF2tO7BA")]
[DisplayName("Cash Settlement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashSettlement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashSettlement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashSettlement2( DataModification2Code reqModificationScopeIndication )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_O7rzwyC3EeWJd9HF2tO7BA")]
    [DisplayName("Modification Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModScpIndctn")]
    #endif
    [IsoXmlTag("ModScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification2Code ModificationScopeIndication { get; init; } 
    #else
    public DataModification2Code ModificationScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Account to credit or debit. When this is an account to debit, this is for the payment of a subscription to an investment fund, a savings plan payment, the purchase of securities or the payment of charges. When this is an account to credit, this is for the payment of an amount as a result of a redemption of investment fund units, the sale of securities, interest and dividend payments. A single account may be specified for all cash movements on the account or cash accounts may be specified for specific types of transactions on the account.
    /// </summary>
    [IsoId("_ZoD24iC3EeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctDtls")]
    #endif
    [IsoXmlTag("CshAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount33? CashAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount33? CashAccountDetails { get; init; } 
    #else
    public CashAccount33? CashAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Method of payment other than a cash account.
    /// </summary>
    [IsoId("_ZoD24yC3EeWJd9HF2tO7BA")]
    [DisplayName("Other Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCshSttlmDtls")]
    #endif
    [IsoXmlTag("OthrCshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument13? OtherCashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument13? OtherCashSettlementDetails { get; init; } 
    #else
    public PaymentInstrument13? OtherCashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
