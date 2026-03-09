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
namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria1Choice
{
    /// <summary>
    /// Identifies a customer identification as the search criteria for the financial institution to do the investigation.
    /// </summary>
    [IsoId("_FX0FVUDHEeGUr-Tp_ntVFg")]
    [DisplayName("Customer Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CustomerIdentification : SearchCriteria1Choice_
    #else
    public partial class CustomerIdentification : SearchCriteria1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CustomerIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CustomerIdentification( PartyIdentification43 reqParty )
        {
            Party = reqParty;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the customer for the investigation.
        /// </summary>
        [IsoId("_fQKf7EyuEeGcV5yVhSZuNw")]
        [DisplayName("Party")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pty")]
        #endif
        [IsoXmlTag("Pty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification43 Party { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification43 Party { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43 Party { get; init; } 
        #else
        public PartyIdentification43 Party { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the authority request related to the identified investigation party.
        /// </summary>
        [IsoId("_jP3PoUyuEeGcV5yVhSZuNw")]
        [DisplayName("Authority Request")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AuthrtyReq")]
        #endif
        [IsoXmlTag("AuthrtyReq")]
        public ValueList<AuthorityInvestigation2> AuthorityRequest { get; init; } = new ValueList<AuthorityInvestigation2>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _jP3PoUyuEeGcV5yVhSZuNw
        
        
        #nullable disable
        
    }
}
