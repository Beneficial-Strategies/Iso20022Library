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
namespace BeneficialStrategies.Iso20022.Choices.AuditTrailOrBusinessError1Choice
{
    /// <summary>
    /// Choice between data concerning static data audit trail retrieved or business error.
    /// </summary>
    [IsoId("_kzT6EO5NEeCisYr99QEiWA_1000290633")]
    [DisplayName("Audit Trail")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AuditTrail : AuditTrailOrBusinessError1Choice_
    #else
    public partial class AuditTrail : AuditTrailOrBusinessError1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AuditTrail instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AuditTrail( System.String reqFieldName,System.String reqOldFieldValue,System.String reqNewFieldValue,System.DateTime reqOperationTimeStamp,System.String reqInstructingUser )
        {
            FieldName = reqFieldName;
            OldFieldValue = reqOldFieldValue;
            NewFieldValue = reqNewFieldValue;
            OperationTimeStamp = reqOperationTimeStamp;
            InstructingUser = reqInstructingUser;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name of the field whose value has been changed.
        /// </summary>
        [IsoId("_kzm1AO5NEeCisYr99QEiWA_1740662573")]
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
        [IsoId("_kzm1Ae5NEeCisYr99QEiWA_-998075288")]
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
        [IsoId("_kzm1Au5NEeCisYr99QEiWA_-1286976113")]
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
        
        /// <summary>
        /// Timestamp of the change.
        /// </summary>
        [IsoId("_kzm1A-5NEeCisYr99QEiWA_-1287417640")]
        [DisplayName("Operation Time Stamp")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OprTmStmp")]
        #endif
        [IsoXmlTag("OprTmStmp")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime OperationTimeStamp { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime OperationTimeStamp { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime OperationTimeStamp { get; init; } 
        #else
        public System.DateTime OperationTimeStamp { get; set; } 
        #endif
        
        /// <summary>
        /// User who instructed the change.
        /// </summary>
        [IsoId("_kzm1BO5NEeCisYr99QEiWA_-1840195094")]
        [DisplayName("Instructing User")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstgUsr")]
        #endif
        [IsoXmlTag("InstgUsr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax256Text InstructingUser { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String InstructingUser { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String InstructingUser { get; init; } 
        #else
        public System.String InstructingUser { get; set; } 
        #endif
        
        /// <summary>
        /// User who approved the change instructed by the instructing user.
        /// </summary>
        [IsoId("_kzm1Be5NEeCisYr99QEiWA_276002183")]
        [DisplayName("Approving User")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ApprvgUsr")]
        #endif
        [IsoXmlTag("ApprvgUsr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax256Text? ApprovingUser { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ApprovingUser { get; init; } 
        #else
        public System.String? ApprovingUser { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
