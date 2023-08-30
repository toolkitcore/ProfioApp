﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Profio.Domain.Entities;
using Profio.Domain.ValueObjects;
using Profio.Infrastructure.Persistence.Converter;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Profio.Infrastructure.Persistence.Relational.Optimization
{
    internal partial class DeliveryProgressEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Profio.Domain.Entities.DeliveryProgress",
                typeof(DeliveryProgress),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(string),
                propertyInfo: typeof(DeliveryProgress).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeliveryProgress).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 26);

            var currentLocation = runtimeEntityType.AddProperty(
                "CurrentLocation",
                typeof(Location),
                propertyInfo: typeof(DeliveryProgress).GetProperty("CurrentLocation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeliveryProgress).GetField("<CurrentLocation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                unicode: true);
            currentLocation.AddAnnotation("Relational:ColumnType", "jsonb");

            var estimatedTimeRemaining = runtimeEntityType.AddProperty(
                "EstimatedTimeRemaining",
                typeof(TimeSpan?),
                propertyInfo: typeof(DeliveryProgress).GetProperty("EstimatedTimeRemaining", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeliveryProgress).GetField("<EstimatedTimeRemaining>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueConverter: new TimeSpanConverter());

            var lastUpdated = runtimeEntityType.AddProperty(
                "LastUpdated",
                typeof(DateTime?),
                propertyInfo: typeof(DeliveryProgress).GetProperty("LastUpdated", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeliveryProgress).GetField("<LastUpdated>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var orderId = runtimeEntityType.AddProperty(
                "OrderId",
                typeof(string),
                propertyInfo: typeof(DeliveryProgress).GetProperty("OrderId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeliveryProgress).GetField("<OrderId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var percentComplete = runtimeEntityType.AddProperty(
                "PercentComplete",
                typeof(byte),
                propertyInfo: typeof(DeliveryProgress).GetProperty("PercentComplete", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeliveryProgress).GetField("<PercentComplete>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { orderId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("OrderId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade);

            var order = declaringEntityType.AddNavigation("Order",
                runtimeForeignKey,
                onDependent: true,
                typeof(Order),
                propertyInfo: typeof(DeliveryProgress).GetProperty("Order", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DeliveryProgress).GetField("<Order>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var deliveryProgresses = principalEntityType.AddNavigation("DeliveryProgresses",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DeliveryProgress>),
                propertyInfo: typeof(Order).GetProperty("DeliveryProgresses", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Order).GetField("<DeliveryProgresses>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DeliveryProgresses");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
