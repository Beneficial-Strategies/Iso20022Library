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
namespace BeneficialStrategies.Iso20022.Choices.PartyOrGroup1Choice
{
    /// <summary>
    /// Specifies a party.
    /// </summary>
    [IsoId("_EjCCgA4UEeKGXqvMN6jpiw")]
    [DisplayName("Party")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Party : PartyOrGroup1Choice_
    #else
    public partial class Party : PartyOrGroup1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Party instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Party( PartyIdentification43 reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Entity involved in an activity.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pty")]
        #endif
        [IsoXmlTag("Pty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification43 Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification43 Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43 Value { get; init; } 
        #else
        public PartyIdentification43 Value { get; set; } 
        #endif
        
        /// <summary>
        /// Security certificate used to sign electronically.
        /// </summary>
        [IsoId("_5pjFlQ4VEeKGXqvMN6jpiw")]
        [DisplayName("Certificate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cert")]
        #endif
        [IsoXmlTag("Cert")]
        [IsoSimpleType(IsoSimpleType.Max10KBinary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax10KBinary? Certificate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Byte[]? Certificate { get; init; } 
        #else
        public System.Byte[]? Certificate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
