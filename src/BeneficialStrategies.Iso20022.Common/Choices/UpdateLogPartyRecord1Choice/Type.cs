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
    /// Specifies the type classification of the party.
    /// </summary>
    [IsoId("_xPt7g2jNEeiRg5NzP0jkQg")]
    [DisplayName("Type")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Type : UpdateLogPartyRecord1Choice_
    #else
    public partial class Type : UpdateLogPartyRecord1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Type instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Type( SystemPartyType1Choice_ reqOld,SystemPartyType1Choice_ reqNew )
        {
            Old = reqOld;
            New = reqNew;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_5Lc0RGjTEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Od")]
        #endif
        [IsoXmlTag("Od")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SystemPartyType1Choice_ Old { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SystemPartyType1Choice_ Old { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyType1Choice_ Old { get; init; } 
        #else
        public SystemPartyType1Choice_ Old { get; set; } 
        #endif
        
        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_5Lc0RWjTEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="New")]
        #endif
        [IsoXmlTag("New")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SystemPartyType1Choice_ New { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SystemPartyType1Choice_ New { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyType1Choice_ New { get; init; } 
        #else
        public SystemPartyType1Choice_ New { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
