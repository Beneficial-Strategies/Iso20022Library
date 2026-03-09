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
    /// Specifies the name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_xPt7iGjNEeiRg5NzP0jkQg")]
    [DisplayName("Name")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Name : UpdateLogPartyRecord1Choice_
    #else
    public partial class Name : UpdateLogPartyRecord1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Name instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Name( PartyName4 reqOld,PartyName4 reqNew )
        {
            Old = reqOld;
            New = reqNew;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_zOmJYWjVEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Od")]
        #endif
        [IsoXmlTag("Od")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyName4 Old { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyName4 Old { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyName4 Old { get; init; } 
        #else
        public PartyName4 Old { get; set; } 
        #endif
        
        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_zOmJYmjVEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="New")]
        #endif
        [IsoXmlTag("New")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyName4 New { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyName4 New { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyName4 New { get; init; } 
        #else
        public PartyName4 New { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
