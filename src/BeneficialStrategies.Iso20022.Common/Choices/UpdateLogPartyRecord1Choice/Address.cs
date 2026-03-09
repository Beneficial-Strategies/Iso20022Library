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
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_xPt7gGjNEeiRg5NzP0jkQg")]
    [DisplayName("Address")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Address : UpdateLogPartyRecord1Choice_
    #else
    public partial class Address : UpdateLogPartyRecord1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Address instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Address( PostalAddress25 reqOld,PostalAddress25 reqNew )
        {
            Old = reqOld;
            New = reqNew;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Old value before change
        /// </summary>
        [IsoId("_U5BZcGjSEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Od")]
        #endif
        [IsoXmlTag("Od")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PostalAddress25 Old { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PostalAddress25 Old { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostalAddress25 Old { get; init; } 
        #else
        public PostalAddress25 Old { get; set; } 
        #endif
        
        /// <summary>
        /// New value after change
        /// </summary>
        [IsoId("_SjDnoGjSEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="New")]
        #endif
        [IsoXmlTag("New")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PostalAddress25 New { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PostalAddress25 New { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostalAddress25 New { get; init; } 
        #else
        public PostalAddress25 New { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
