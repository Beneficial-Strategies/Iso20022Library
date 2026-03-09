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
namespace BeneficialStrategies.Iso20022.Choices.StatementUpdateTypeCodeAndDSSCode1Choice
{
    /// <summary>
    /// Update type expressed as a code.
    /// </summary>
    [IsoId("_sXPbwQaUEe2-DuDrUXkg2w")]
    [DisplayName("Statement Update Type As Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StatementUpdateTypeAsCode : StatementUpdateTypeCodeAndDSSCode1Choice_
    #else
    public partial class StatementUpdateTypeAsCode : StatementUpdateTypeCodeAndDSSCode1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a StatementUpdateTypeAsCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public StatementUpdateTypeAsCode( StatementUpdateType1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of a statement update, for example, it is a complete statement.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StmtUpdTpAsCd")]
        #endif
        [IsoXmlTag("StmtUpdTpAsCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required StatementUpdateType1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required StatementUpdateType1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StatementUpdateType1Code Value { get; init; } 
        #else
        public StatementUpdateType1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
