CREATE TABLE remote_devices
(
    id             serial PRIMARY KEY,
    name           VARCHAR(50)  NOT NULL,
    hostname       VARCHAR(100) NOT NULL,
    device_type    VARCHAR(30)  NOT NULL DEFAULT 'LedStrip',
    min_brightness INTEGER,
    max_brightness INTEGER,
    created_at     TIMESTAMP NOT NULL,
    updated_at     TIMESTAMP NOT NULL
);