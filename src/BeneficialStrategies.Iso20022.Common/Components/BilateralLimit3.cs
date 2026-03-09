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
/// Characteristics and values set for a bilateral limit, including the counterparty upon which the limit applies.
/// </summary>
[IsoId("_FuKlIW4-EeiU9cctagi5ow")]
[DisplayName("Bilateral Limit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BilateralLimit3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BilateralLimit3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BilateralLimit3( BranchAndFinancialInstitutionIdentification6 reqCounterpartyIdentification,Amount2Choice_ reqLimitAmount,CreditDebitCode reqCreditDebitIndicator )
    {
        CounterpartyIdentification = reqCounterpartyIdentification;
        LimitAmount = reqLimitAmount;
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    [IsoId("_F3jKo24-EeiU9cctagi5ow")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 CounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 CounterpartyIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_F3jKpW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtAmt")]
    #endif
    [IsoXmlTag("LmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2Choice_ LimitAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2Choice_ LimitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_ LimitAmount { get; init; } 
    #else
    public Amount2Choice_ LimitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if a limit is a debit limit or a credit limit.
    /// </summary>
    [IsoId("_F3jKp24-EeiU9cctagi5ow")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Balance calculated with regard to one member in the system.
    /// </summary>
    [IsoId("_F3jKqW4-EeiU9cctagi5ow")]
    [DisplayName("Bilateral Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilBal")]
    #endif
    [IsoXmlTag("BilBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalance11? BilateralBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalance11? BilateralBalance { get; init; } 
    #else
    public CashBalance11? BilateralBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
