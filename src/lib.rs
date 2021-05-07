// Common part

pub fn random(seed: f32) -> f32 {
    let newval = (seed+3.14159).powf(8.);
    newval - newval.trunc()
}

