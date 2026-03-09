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
/// Provides details about the securities compensation such as the depository and the total settlement amount.
/// </summary>
[IsoId("_Uot1kdp-Ed-ak6NoX_4Aeg_-1569066973")]
[DisplayName("Securities Compensation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesCompensation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesCompensation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesCompensation1( PartyIdentification34Choice_ reqDepository,AmountAndDirection20 reqSettlementAmount )
    {
        Depository = reqDepository;
        SettlementAmount = reqSettlementAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_Uot1ktp-Ed-ak6NoX_4Aeg_2036151037")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification34Choice_ Depository { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification34Choice_ Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification34Choice_ Depository { get; init; } 
    #else
    public PartyIdentification34Choice_ Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the total amount of money to be settled.
    /// </summary>
    [IsoId("_Uot1k9p-Ed-ak6NoX_4Aeg_-183187365")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection20 SettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection20 SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20 SettlementAmount { get; init; } 
    #else
    public AmountAndDirection20 SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money related to the fees for the securities compensation.
    /// </summary>
    [IsoId("_Uot1lNp-Ed-ak6NoX_4Aeg_-846472432")]
    [DisplayName("Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fees")]
    #endif
    [IsoXmlTag("Fees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection20? Fees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection20? Fees { get; init; } 
    #else
    public AmountAndDirection20? Fees { get; set; } 
    #endif
    
    
    #nullable disable
    
}
