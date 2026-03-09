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
    /// Specifies a proprietary update type.
    /// </summary>
    [IsoId("_7aOnsWjNEeiRg5NzP0jkQg")]
    [DisplayName("Other")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : UpdateLogPartyRecord1Choice_
    #else
    public partial class Other : UpdateLogPartyRecord1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Other instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Other( System.String reqFieldName,System.String reqOldFieldValue,System.String reqNewFieldValue )
        {
            FieldName = reqFieldName;
            OldFieldValue = reqOldFieldValue;
            NewFieldValue = reqNewFieldValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name of the field whose value has been changed.
        /// </summary>
        [IsoId("_LituOWjOEeiRg5NzP0jkQg")]
        [DisplayName("Field Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FldNm")]
        #endif
        [IsoXmlTag("FldNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text FieldName { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String FieldName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String FieldName { get; init; } 
        #else
        public System.String FieldName { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the field before the change.
        /// </summary>
        [IsoId("_LituPmjOEeiRg5NzP0jkQg")]
        [DisplayName("Old Field Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OdFldVal")]
        #endif
        [IsoXmlTag("OdFldVal")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text OldFieldValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String OldFieldValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String OldFieldValue { get; init; } 
        #else
        public System.String OldFieldValue { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the field after the change.
        /// </summary>
        [IsoId("_LituPGjOEeiRg5NzP0jkQg")]
        [DisplayName("New Field Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NewFldVal")]
        #endif
        [IsoXmlTag("NewFldVal")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text NewFieldValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String NewFieldValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String NewFieldValue { get; init; } 
        #else
        public System.String NewFieldValue { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
