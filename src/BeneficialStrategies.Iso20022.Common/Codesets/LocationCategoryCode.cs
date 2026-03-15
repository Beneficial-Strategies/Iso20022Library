// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Location category code of the place where the merchant actually performed the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUvzEAEcEeCQm6a_G2yO_w_-212887785")]
[Description(@"Location category code of the place where the merchant actually performed the transaction.")]
[Derivations(typeof(LocationCategory1Code),typeof(LocationCategory2Code),typeof(LocationCategory3Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum LocationCategoryCode
{
    /// <summary>
    /// Fixed location, for example in a shop.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_TUvzEQEcEeCQm6a_G2yO_w_-2072023787")]
    [Description(@"Fixed location, for example in a shop.")]
    Fixed,
    
    /// <summary>
    /// Aboard a bus, train, ship, airplane, taxi, etc.
    /// Encoded/decoded by serializers as &quot;ABRD&quot;.
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_TUvzEgEcEeCQm6a_G2yO_w_-632717979")]
    [Description(@"Aboard a bus, train, ship, airplane, taxi, etc.")]
    Aboard,
    
    /// <summary>
    /// Nomadic location.
    /// Encoded/decoded by serializers as &quot;NMDC&quot;.
    /// </summary>
    [EnumMember(Value = "NMDC")]
    [IsoId("_TUvzEwEcEeCQm6a_G2yO_w_515385128")]
    [Description(@"Nomadic location.")]
    Nomadic,
    
    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as &quot;MOTO&quot;.
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_TUvzFAEcEeCQm6a_G2yO_w_1800464399")]
    [Description(@"Mail order or telephone order.")]
    MailOrderTelephoneOrder,
    
    /// <summary>
    /// Customer home.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_TUvzFQEcEeCQm6a_G2yO_w_-566393141")]
    [Description(@"Customer home.")]
    Home,
    
    /// <summary>
    /// Indoor terminal.
    /// Encoded/decoded by serializers as &quot;INDR&quot;.
    /// </summary>
    [EnumMember(Value = "INDR")]
    [IsoId("_YppBoJX5EeWMQt4mOczoDw")]
    [Description(@"Indoor terminal.")]
    Indoor,
    
    /// <summary>
    /// Terminal incorporated in the pump dispensing petrol.
    /// Encoded/decoded by serializers as &quot;IPMP&quot;.
    /// </summary>
    [EnumMember(Value = "IPMP")]
    [IsoId("_bTq-8JX5EeWMQt4mOczoDw")]
    [Description(@"Terminal incorporated in the pump dispensing petrol.")]
    InsidePump,
    
    /// <summary>
    /// Outdoor terminal serving several petrol pumps.
    /// Encoded/decoded by serializers as &quot;MPMP&quot;.
    /// </summary>
    [EnumMember(Value = "MPMP")]
    [IsoId("_d8s2sJX5EeWMQt4mOczoDw")]
    [Description(@"Outdoor terminal serving several petrol pumps.")]
    MultiplePump,
    
    /// <summary>
    /// Multiple terminals linked to a unique sale terminal.
    /// Encoded/decoded by serializers as &quot;MPOI&quot;.
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_ifu9AJX5EeWMQt4mOczoDw")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MultiplePOITerminal,
    
    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// Encoded/decoded by serializers as &quot;MSLE&quot;.
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_kr-yIJX5EeWMQt4mOczoDw")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MultipleSaleTerminal,
    
    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// Encoded/decoded by serializers as &quot;SSLE&quot;.
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_pI4bQJX5EeWMQt4mOczoDw")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SingleSaleTerminal,
    
    /// <summary>
    /// Terminal integrated in a vending machine.
    /// Encoded/decoded by serializers as &quot;VNDG&quot;.
    /// </summary>
    [EnumMember(Value = "VNDG")]
    [IsoId("_sdowkJX5EeWMQt4mOczoDw")]
    [Description(@"Terminal integrated in a vending machine.")]
    VendingMachine,
    
    /// <summary>
    /// Virtual Shop is used for any ecommerce solution.
    /// Encoded/decoded by serializers as &quot;VIRT&quot;.
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_7imhYEUJEeuSWeURYeKGvg")]
    [Description(@"Virtual Shop is used for any ecommerce solution.")]
    VirtualShop,
    
}
