// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountModification1Choice
{
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_hjLnbWliEeGaMcKyqKNRfQ_1718071674")]
    [DisplayName("Market Specific Attribute")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarketSpecificAttribute : SecuritiesAccountModification1Choice_
    #else
    public partial class MarketSpecificAttribute : SecuritiesAccountModification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarketSpecificAttribute instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarketSpecificAttribute( System.String reqName,System.String reqValue )
        {
            Name = reqName;
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the name of the market-specific attribute.
        /// </summary>
        [IsoId("_klTTQ-5NEeCisYr99QEiWA_1518015458")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the value of the market-specific attribute.
        /// </summary>
        [IsoId("_kldEQO5NEeCisYr99QEiWA_1961003950")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
