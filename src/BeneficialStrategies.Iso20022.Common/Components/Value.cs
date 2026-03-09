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
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SVDJ0dp-Ed-ak6NoX_4Aeg_-76711377")]
[DisplayName("Value")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Value
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Value instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Value( ActiveOrHistoricCurrencyAndAmount reqBaseCurrencyItem )
    {
        BaseCurrencyItem = reqBaseCurrencyItem;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the amount in the base currency of the receiver.
    /// </summary>
    [IsoId("_SVDJ0tp-Ed-ak6NoX_4Aeg_-37000375")]
    [DisplayName("Base Currency Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseCcyItm")]
    #endif
    [IsoXmlTag("BaseCcyItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount BaseCurrencyItem { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount BaseCurrencyItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount BaseCurrencyItem { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount BaseCurrencyItem { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount in another currency.
    /// </summary>
    [IsoId("_SVDJ09p-Ed-ak6NoX_4Aeg_249291013")]
    [DisplayName("Alternate Currency Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnCcyItm")]
    #endif
    [IsoXmlTag("AltrnCcyItm")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> AlternateCurrencyItem { get; init; } = new ValueList<ActiveOrHistoricCurrencyAndAmount>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SVDJ09p-Ed-ak6NoX_4Aeg_249291013
    
    
    #nullable disable
    
}
