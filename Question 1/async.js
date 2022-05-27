async function statusUpdate(
  id,
  latitude,
  longitude,
  batteryLevel,
  signalStrength,
  date,
  hasDisconnected,
  isOnline
) {
  /* ... */
}

async function updateStatus() {
  const drivers = await driverService.getDrivers();

  const driverUpdateCalls = drivers.map(async (driver) => {
    const { id, latitude, longitude, batteryLevel, signalStrength } = driver;

    await statusUpdate(
      id,
      latitude,
      longitude,
      batteryLevel,
      signalStrength,
      new Date(),
      false,
      true
    );
  });

  await Promise.all(driverUpdateCalls);
}
