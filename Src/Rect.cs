﻿using System;
using System.Runtime.InteropServices;

namespace VulkanCore
{
    /// <summary>
    /// Structure specifying a two-dimensional subregion.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect2D : IEquatable<Rect2D>
    {
        /// <summary>
        /// The offset component of the rectangle.
        /// </summary>
        public Offset2D Offset;
        /// <summary>
        /// The extent component of the rectangle.
        /// </summary>
        public Extent2D Extent;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rect2D"/> structure.
        /// </summary>
        /// <param name="offset">The offset component of the rectangle.</param>
        /// <param name="extent">The extent component of the rectangle.</param>
        public Rect2D(Offset2D offset, Extent2D extent)
        {
            Offset = offset;
            Extent = extent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rect2D"/> structure.
        /// </summary>
        /// <param name="x">The X component of the offset.</param>
        /// <param name="y">The Y component of the offset.</param>
        /// <param name="width">The width component of the extent.</param>
        /// <param name="height">The height component of the extent.</param>
        public Rect2D(int x, int y, int width, int height)
            : this(new Offset2D(x, y), new Extent2D(width, height))
        {
        }

        /// <summary>
        /// Determines whether the specified <see cref="Rect2D"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="Rect2D"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="Rect2D"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Rect2D other) => other.Offset == Offset && other.Extent == Extent;

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => obj is Rect2D && Equals((Rect2D)obj);

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Extent.GetHashCode();
                hashCode = (hashCode * 397) ^ Offset.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns a boolean indicating whether the two given rectangles are equal.
        /// </summary>
        /// <param name="left">The first rectangle to compare.</param>
        /// <param name="right">The second rectangle to compare.</param>
        /// <returns><c>true</c> if the rectangles are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Rect2D left, Rect2D right) => left.Equals(right);

        /// <summary>
        /// Returns a boolean indicating whether the two given rectangles are not equal.
        /// </summary>
        /// <param name="left">The first rectangle to compare.</param>
        /// <param name="right">The second rectangle to compare.</param>
        /// <returns>
        /// <c>true</c> if the rectangles are not equal; <c>false</c> if they are equal.
        /// </returns>
        public static bool operator !=(Rect2D left, Rect2D right) => !left.Equals(right);
    }

    /// <summary>
    /// Structure specifying a three-dimensional subregion.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect3D : IEquatable<Rect3D>
    {
        /// <summary>
        /// The offset component of the cuboid.
        /// </summary>
        public Offset3D Offset;
        /// <summary>
        /// The extent component of the cuboid.
        /// </summary>
        public Extent3D Extent;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rect3D"/> structure.
        /// </summary>
        /// <param name="offset">The offset component of the rectangle.</param>
        /// <param name="extent">The extent component of the rectangle.</param>
        public Rect3D(Offset3D offset, Extent3D extent)
        {
            Offset = offset;
            Extent = extent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rect2D"/> structure.
        /// </summary>
        /// <param name="x">The X component of the offset.</param>
        /// <param name="y">The Y component of the offset.</param>
        /// <param name="z">The Z component of the offset.</param>
        /// <param name="width">The width component of the extent.</param>
        /// <param name="height">The height component of the extent.</param>
        /// <param name="depth">The depth component of the extent.</param>
        public Rect3D(int x, int y, int z, int width, int height, int depth)
            : this(new Offset3D(x, y, z), new Extent3D(width, height, depth))
        {
        }

        /// <summary>
        /// Determines whether the specified <see cref="Rect3D"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="Rect3D"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="Rect3D"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Rect3D other) => other.Offset == Offset && other.Extent == Extent;

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => obj is Rect3D && Equals((Rect3D)obj);

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Extent.GetHashCode();
                hashCode = (hashCode * 397) ^ Offset.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns a boolean indicating whether the two given rectangles are equal.
        /// </summary>
        /// <param name="left">The first rectangle to compare.</param>
        /// <param name="right">The second rectangle to compare.</param>
        /// <returns><c>true</c> if the rectangles are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Rect3D left, Rect3D right) => left.Equals(right);

        /// <summary>
        /// Returns a boolean indicating whether the two given rectangles are not equal.
        /// </summary>
        /// <param name="left">The first rectangle to compare.</param>
        /// <param name="right">The second rectangle to compare.</param>
        /// <returns>
        /// <c>true</c> if the rectangles are not equal; <c>false</c> if they are equal.
        /// </returns>
        public static bool operator !=(Rect3D left, Rect3D right) => !left.Equals(right);
    }

    /// <summary>
    /// Structure specifying a clear rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ClearRect
    {
        /// <summary>
        /// The two-dimensional region to be cleared.
        /// </summary>
        public Rect2D Rect;
        /// <summary>
        /// The first layer to be cleared.
        /// </summary>
        public int BaseArrayLayer;
        /// <summary>
        /// The number of layers to clear.
        /// </summary>
        public int LayerCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearRect"/> structure.
        /// </summary>
        /// <param name="rect">The two-dimensional region to be cleared.</param>
        /// <param name="baseArrayLayer">The first layer to be cleared.</param>
        /// <param name="layerCount">The number of layers to clear.</param>
        public ClearRect(Rect2D rect, int baseArrayLayer, int layerCount)
        {
            Rect = rect;
            BaseArrayLayer = baseArrayLayer;
            LayerCount = layerCount;
        }
    }
}
